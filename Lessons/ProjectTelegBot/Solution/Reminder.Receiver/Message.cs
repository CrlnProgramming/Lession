using System;
using System.Collections.Generic;
using System.Linq;

namespace Reminder.Receiver
{
	public class Message
	{
		public class DateTimeWellKnownFormat
		{
			public readonly string[] Tokens;
			private readonly Func<double, TimeSpan> _offset;

			public DateTimeWellKnownFormat(string[] tokens, Func<double, TimeSpan> offset)
			{
				Tokens = tokens;
				_offset = offset;
			}
			public TimeSpan Offset(int amount) => _offset(amount);
		}
		public static readonly char[] Separators = {'\n', ',', ';'};
		public static readonly DateTimeWellKnownFormat[] DateTimeFormats =
		{
			new DateTimeWellKnownFormat(new[] {"d", "day", "days"}, TimeSpan.FromDays),
			new DateTimeWellKnownFormat(new[] {"h", "hour", "hours"}, TimeSpan.FromHours), 
			new DateTimeWellKnownFormat(new[] {"m", "min", "minutes"}, TimeSpan.FromMinutes),
			new DateTimeWellKnownFormat(new[] {"s", "sec", "seconds"}, TimeSpan.FromSeconds),
		};

		public string Header { get; }
		public DateTimeOffset DateTimeUtc { get; }
		public string Text { get; }

		public Message(string header, DateTimeOffset dateTimeUtc, string text)
		{
			Header = header;
			DateTimeUtc = dateTimeUtc;
			Text = text;
		}

		public static Message Parse(string text)
		{
			if (string.IsNullOrWhiteSpace(text))
			{
				throw new ArgumentNullException(nameof(text));
			}

			var parts = GetTokens(text);
			if (parts.Length < 2)
			{
				throw new ArgumentException("The string contains invalid number of parts", nameof(text));
			}

			return new Message(
				parts.First(),
				ParseDatetime(parts.Skip(1).First()),
				ParseMessage(parts.Skip(2)));
		}

		private static DateTimeOffset ParseDatetime(string input)
		{
			if (string.Equals(input, "tomorrow", StringComparison.OrdinalIgnoreCase))
			{
				return DateTimeOffset.UtcNow.AddDays(1);
			}

			var parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
			if (parts.Length == 2 && int.TryParse(parts[0], out var amount))
			{
				var descriptor = DateTimeFormats.FirstOrDefault(pair =>
					pair.Tokens.Contains(parts[1])
				);

				if (descriptor != null)
				{
					return DateTimeOffset.UtcNow.Add(descriptor.Offset(amount));
				}
			}

			return DateTimeOffset.TryParse(input, out var result)
				? result
				: throw new ArgumentException("The expected datetime string was in invalid format");
		}

		private static string ParseMessage(IEnumerable<string> parts) =>
			parts.Any()
				? string.Join(Environment.NewLine, parts)
				: string.Empty;

		private static string[] GetTokens(string text) =>
			text.Split(Separators, StringSplitOptions.RemoveEmptyEntries);
	}
}
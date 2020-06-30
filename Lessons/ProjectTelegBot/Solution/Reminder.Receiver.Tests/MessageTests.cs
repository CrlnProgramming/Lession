using System;
using NUnit.Framework;

namespace Reminder.Receiver.Tests
{
	public class MessageTests
	{
		[TestCase(null)]
		[TestCase("")]
		[TestCase("               ")]
		public void GivenNullOrEmptyString_WhenParseInvoked_ThenThrowArgumentNullException(string text)
		{
			Assert.Catch<ArgumentNullException>(() =>
				Message.Parse(text)
			);
		}

		[TestCase(";")]
		[TestCase("1a")]
		public void GivenStringWithoutSeparators_WhenParseInvoked_ThenThrowArgumentException(string text)
		{
			var exception = Assert.Catch<ArgumentException>(() =>
				Message.Parse(text)
			);
			StringAssert.Contains("The string contains invalid number of parts", exception.Message);
		}

		[TestCase("1a\naa\na")]
		public void GivenStringWithoutCorrectDatetime_WhenParseInvoked_ThenThrowArgumentException(string text)
		{
			var exception = Assert.Catch<ArgumentException>(() =>
				Message.Parse(text)
			);
			StringAssert.Contains("The expected datetime string was in invalid format", exception.Message);
		}

		[TestCase("Header", "2020.05.25T20:00:08", "Message", '\n')]
		[TestCase("Header", "2020.05.25T20:00:08+03", "Message", '\n')]
		[TestCase("Header", "2020.05.25T20:00:08+03", "Message", ';')]
		[TestCase("Header", "2020.05.25T20:00:08+03", "Message", ',')]
		public void GivenStringInValidFormat_WhenParseInvoked_ThenReturnMessageWithComponents(
			string header,
			string datetime,
			string text,
			char separator)
		{
			var message = Message.Parse($"{header}{separator}{datetime}{separator}{text}");

			Assert.AreEqual(header, message.Header);
			Assert.AreEqual(DateTimeOffset.Parse(datetime), message.DateTimeUtc);
			Assert.AreEqual(text, message.Text);
		}

		[TestCase("Header", "10 seconds", "Message", "\n")]
		[TestCase("Header", "10 sec", "Message", "\n")]
		[TestCase("Header", "10 s", "Message", "\n")]
		[TestCase("Header", "10 sec", "Message", ";")]
		public void GivenDatetimeStringInWellKnownFormats_WhenParseInvoked_ThenReturnDatetimeWithValidOffset(
			string header,
			string datetime,
			string text,
			string separator)
		{
			var expectedDatetime = DateTimeOffset.UtcNow;
			var message = Message.Parse($"{header}{separator}{datetime}{separator}{text}");

			Assert.GreaterOrEqual(message.DateTimeUtc - expectedDatetime, TimeSpan.FromSeconds(10));
		}
	}
}
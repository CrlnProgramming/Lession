--Bot ReminderStorage DateBase

CREATE TABLE ReminderItem (
    [Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
    [Title] VARCHAR (70) NOT NULL,
    [Message] VARCHAR (300) NOT NULL,
    [DateTimeUtc] datetimeoffset NOT NULL,
    [ItemStatusId] TINYINT NOT NULL,
    [UserId] int NOT NULL
);
SELECT * FROM ReminderItem;

CREATE TABLE ItemStatus (
    [Id] TINYINT NOT NULL PRIMARY KEY,
    [StatusName] VARCHAR (20) NOT NULL,
);
SELECT * FROM ItemStatus;

Create TABLE Users (
    [Id] INT PRIMARY KEY IDENTITY(1,1),
    [Login] VARCHAR (60) NOT NULL,
    [ChatId] VARCHAR (60) NOT NULL,
);
SELECT * FROM Users;

Insert into ItemStatus
VALUES
(0, 'Undefined'),
(1, 'Created'),
(2, 'Ready'),
(3, 'Sent'),
(4, 'Failed');

Insert into Users
VALUES 
('Makoveev', '595274794');

Alter TABLE ReminderItem
Add CONSTRAINT FK_ItemStatusId FOREIGN KEY (ItemStatusId)
REFERENCES ItemStatus(Id)
On DELETE CASCADE
on UPDATE CASCADE

Alter TABLE ReminderItem
Add CONSTRAINT FK_UserId FOREIGN KEY (UserId)
REFERENCES Users(Id)
On DELETE CASCADE
on UPDATE CASCADE

INSERT into ReminderItem
VALUES 
('bgfng34-fcds-5646-54435-564fgfd', 'Now Year','Remind about this', '2020-12-31 00:00:00.0000 +01:0', 1, 1);

SELECT * from ReminderItem;

DROP TABLE ReminderItem;
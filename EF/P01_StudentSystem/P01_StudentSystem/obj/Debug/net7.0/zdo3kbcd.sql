IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Course] (
    [CourseID] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    [Desc] nvarchar(max) NULL,
    [StartDate] datetime2 NOT NULL,
    [EndDate] datetime2 NOT NULL,
    [Price] float NOT NULL,
    [StudentID] int NOT NULL,
    CONSTRAINT [PK_Course] PRIMARY KEY ([CourseID])
);
GO

CREATE TABLE [Resource] (
    [ResourceID] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    [Url] varchar(max) NOT NULL,
    [ResourceType] int NOT NULL,
    [CourseID] int NOT NULL,
    CONSTRAINT [PK_Resource] PRIMARY KEY ([ResourceID]),
    CONSTRAINT [FK_Resource_Course_CourseID] FOREIGN KEY ([CourseID]) REFERENCES [Course] ([CourseID]) ON DELETE NO ACTION
);
GO

CREATE TABLE [Student] (
    [StudentID] int NOT NULL IDENTITY,
    [BirthDay] datetime2 NULL,
    [Name] nvarchar(max) NOT NULL,
    [PhoneNumber] nvarchar(10) NULL,
    [RegisteredOn] datetime2 NOT NULL,
    [CourseID] int NOT NULL,
    CONSTRAINT [PK_Student] PRIMARY KEY ([StudentID]),
    CONSTRAINT [FK_Student_Course_CourseID] FOREIGN KEY ([CourseID]) REFERENCES [Course] ([CourseID]) ON DELETE NO ACTION
);
GO

CREATE TABLE [Homework] (
    [HomeworkID] int NOT NULL IDENTITY,
    [Content] varchar(max) NOT NULL,
    [ContentType] int NOT NULL,
    [SubmissionTime] datetime2 NOT NULL,
    [StudentID] int NOT NULL,
    [CourseID] int NOT NULL,
    CONSTRAINT [PK_Homework] PRIMARY KEY ([HomeworkID]),
    CONSTRAINT [FK_Homework_Course_CourseID] FOREIGN KEY ([CourseID]) REFERENCES [Course] ([CourseID]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Homework_Student_StudentID] FOREIGN KEY ([StudentID]) REFERENCES [Student] ([StudentID]) ON DELETE NO ACTION
);
GO

CREATE INDEX [IX_Course_StudentID] ON [Course] ([StudentID]);
GO

CREATE INDEX [IX_Homework_CourseID] ON [Homework] ([CourseID]);
GO

CREATE INDEX [IX_Homework_StudentID] ON [Homework] ([StudentID]);
GO

CREATE INDEX [IX_Resource_CourseID] ON [Resource] ([CourseID]);
GO

CREATE INDEX [IX_Student_CourseID] ON [Student] ([CourseID]);
GO

ALTER TABLE [Course] ADD CONSTRAINT [FK_Course_Student_StudentID] FOREIGN KEY ([StudentID]) REFERENCES [Student] ([StudentID]) ON DELETE NO ACTION;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240229021712_InitialCreate', N'7.0.16');
GO

COMMIT;
GO


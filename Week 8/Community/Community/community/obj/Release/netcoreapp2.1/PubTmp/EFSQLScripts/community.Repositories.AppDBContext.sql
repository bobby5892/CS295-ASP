IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181118034035_Initial')
BEGIN
    CREATE TABLE [Locations] (
        [ID] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [Link] nvarchar(max) NULL,
        CONSTRAINT [PK_Locations] PRIMARY KEY ([ID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181118034035_Initial')
BEGIN
    CREATE TABLE [Persons] (
        [ID] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [Link] nvarchar(max) NULL,
        CONSTRAINT [PK_Persons] PRIMARY KEY ([ID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181118034035_Initial')
BEGIN
    CREATE TABLE [Users] (
        [ID] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [EmailAddress] nvarchar(max) NULL,
        CONSTRAINT [PK_Users] PRIMARY KEY ([ID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181118034035_Initial')
BEGIN
    CREATE TABLE [Messages] (
        [ID] int NOT NULL IDENTITY,
        [ToID] int NULL,
        [FromID] int NULL,
        [Timestamp] datetime2 NOT NULL,
        [Msge] nvarchar(max) NULL,
        [Subject] nvarchar(max) NULL,
        [IsPriority] bit NOT NULL,
        CONSTRAINT [PK_Messages] PRIMARY KEY ([ID]),
        CONSTRAINT [FK_Messages_Users_FromID] FOREIGN KEY ([FromID]) REFERENCES [Users] ([ID]) ON DELETE NO ACTION,
        CONSTRAINT [FK_Messages_Users_ToID] FOREIGN KEY ([ToID]) REFERENCES [Users] ([ID]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181118034035_Initial')
BEGIN
    CREATE INDEX [IX_Messages_FromID] ON [Messages] ([FromID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181118034035_Initial')
BEGIN
    CREATE INDEX [IX_Messages_ToID] ON [Messages] ([ToID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181118034035_Initial')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ID', N'Name', N'EmailAddress') AND [object_id] = OBJECT_ID(N'[Users]'))
        SET IDENTITY_INSERT [Users] ON;
    INSERT INTO [Users] ([ID], [Name], [EmailAddress])
    VALUES (1, N'Bob', N'bob@example.com');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ID', N'Name', N'EmailAddress') AND [object_id] = OBJECT_ID(N'[Users]'))
        SET IDENTITY_INSERT [Users] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181118034035_Initial')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ID', N'Name', N'EmailAddress') AND [object_id] = OBJECT_ID(N'[Users]'))
        SET IDENTITY_INSERT [Users] ON;
    INSERT INTO [Users] ([ID], [Name], [EmailAddress])
    VALUES (2, N'ted', N'ted@example.com');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ID', N'Name', N'EmailAddress') AND [object_id] = OBJECT_ID(N'[Users]'))
        SET IDENTITY_INSERT [Users] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181118034035_Initial')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ID', N'Name', N'Link') AND [object_id] = OBJECT_ID(N'[Locations]'))
        SET IDENTITY_INSERT [Locations] ON;
    INSERT INTO [Locations] ([ID], [Name], [Link])
    VALUES (1, N'Google', N'google.com');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ID', N'Name', N'Link') AND [object_id] = OBJECT_ID(N'[Locations]'))
        SET IDENTITY_INSERT [Locations] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181118034035_Initial')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ID', N'Name', N'Link') AND [object_id] = OBJECT_ID(N'[Locations]'))
        SET IDENTITY_INSERT [Locations] ON;
    INSERT INTO [Locations] ([ID], [Name], [Link])
    VALUES (2, N'Example', N'example.com');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ID', N'Name', N'Link') AND [object_id] = OBJECT_ID(N'[Locations]'))
        SET IDENTITY_INSERT [Locations] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181118034035_Initial')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ID', N'ToID', N'FromID', N'TimeStamp', N'Msge', N'Subject', N'isPriority') AND [object_id] = OBJECT_ID(N'[Messages]'))
        SET IDENTITY_INSERT [Messages] ON;
    INSERT INTO [Messages] ([ID], [ToID], [FromID], [TimeStamp], [Msge], [Subject], [isPriority])
    VALUES (1, 1, 2, '2018-11-19T19:40:34.7153082-08:00', N'Hey Bob this is ted', N'welcome', 0);
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ID', N'ToID', N'FromID', N'TimeStamp', N'Msge', N'Subject', N'isPriority') AND [object_id] = OBJECT_ID(N'[Messages]'))
        SET IDENTITY_INSERT [Messages] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181118034035_Initial')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ID', N'ToID', N'FromID', N'TimeStamp', N'Msge', N'Subject', N'isPriority') AND [object_id] = OBJECT_ID(N'[Messages]'))
        SET IDENTITY_INSERT [Messages] ON;
    INSERT INTO [Messages] ([ID], [ToID], [FromID], [TimeStamp], [Msge], [Subject], [isPriority])
    VALUES (2, 2, 1, '2018-11-19T19:40:34.7165702-08:00', N'Hey Ted this is bob', N'welcome', 0);
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ID', N'ToID', N'FromID', N'TimeStamp', N'Msge', N'Subject', N'isPriority') AND [object_id] = OBJECT_ID(N'[Messages]'))
        SET IDENTITY_INSERT [Messages] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181118034035_Initial')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20181118034035_Initial', N'2.1.4-rtm-31024');
END;

GO


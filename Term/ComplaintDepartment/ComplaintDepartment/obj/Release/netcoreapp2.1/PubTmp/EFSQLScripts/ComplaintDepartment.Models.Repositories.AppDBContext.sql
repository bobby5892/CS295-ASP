IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181123183607_initial')
BEGIN
    CREATE TABLE [Comments] (
        [ID] int NOT NULL IDENTITY,
        [ComplaintID] int NOT NULL,
        [Contents] nvarchar(max) NULL,
        CONSTRAINT [PK_Comments] PRIMARY KEY ([ID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181123183607_initial')
BEGIN
    CREATE TABLE [Complaints] (
        [ID] int NOT NULL IDENTITY,
        [Create] datetime2 NOT NULL,
        [Contents] nvarchar(max) NULL,
        [Completed] bit NOT NULL,
        CONSTRAINT [PK_Complaints] PRIMARY KEY ([ID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181123183607_initial')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20181123183607_initial', N'2.1.4-rtm-31024');
END;

GO


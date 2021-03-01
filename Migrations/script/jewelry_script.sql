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

CREATE TABLE [UserLogin] (
    [UserId] bigint NOT NULL IDENTITY,
    [UserName] nvarchar(max) NOT NULL,
    [Password] nvarchar(max) NOT NULL,
    [UserType] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_UserLogin] PRIMARY KEY ([UserId])
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'UserId', N'Password', N'UserName', N'UserType') AND [object_id] = OBJECT_ID(N'[UserLogin]'))
    SET IDENTITY_INSERT [UserLogin] ON;
INSERT INTO [UserLogin] ([UserId], [Password], [UserName], [UserType])
VALUES (CAST(1 AS bigint), N'Shubham', N'shubham', N'normal');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'UserId', N'Password', N'UserName', N'UserType') AND [object_id] = OBJECT_ID(N'[UserLogin]'))
    SET IDENTITY_INSERT [UserLogin] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'UserId', N'Password', N'UserName', N'UserType') AND [object_id] = OBJECT_ID(N'[UserLogin]'))
    SET IDENTITY_INSERT [UserLogin] ON;
INSERT INTO [UserLogin] ([UserId], [Password], [UserName], [UserType])
VALUES (CAST(2 AS bigint), N'Sridhar', N'sridhar', N'privileged');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'UserId', N'Password', N'UserName', N'UserType') AND [object_id] = OBJECT_ID(N'[UserLogin]'))
    SET IDENTITY_INSERT [UserLogin] OFF;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210301192416_jewelry_03_03_2021_1', N'5.0.3');
GO

COMMIT;
GO


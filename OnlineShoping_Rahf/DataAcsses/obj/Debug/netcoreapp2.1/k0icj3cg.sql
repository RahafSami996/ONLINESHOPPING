ALTER TABLE [Carts] DROP CONSTRAINT [FK_Carts_Products_ProductsId];

GO

DROP INDEX [IX_Carts_ProductsId] ON [Carts];

GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Carts]') AND [c].[name] = N'ProductsId');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Carts] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [Carts] DROP COLUMN [ProductsId];

GO

UPDATE [AspNetRoles] SET [ConcurrencyStamp] = N'53fc6b45-3a88-4b49-a621-01961e4fbc6f'
WHERE [Id] = 1;
SELECT @@ROWCOUNT;


GO

UPDATE [AspNetRoles] SET [ConcurrencyStamp] = N'd94f4476-608a-4438-93b6-0534417b3133'
WHERE [Id] = 2;
SELECT @@ROWCOUNT;


GO

UPDATE [AspNetRoles] SET [ConcurrencyStamp] = N'0cfb8fd9-0c9e-408b-a6ed-ad2bb0dd35fd'
WHERE [Id] = 3;
SELECT @@ROWCOUNT;


GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name') AND [object_id] = OBJECT_ID(N'[Statuses]'))
    SET IDENTITY_INSERT [Statuses] ON;
INSERT INTO [Statuses] ([Id], [Name])
VALUES (1, N'Active'),
(2, N'UnActive');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name') AND [object_id] = OBJECT_ID(N'[Statuses]'))
    SET IDENTITY_INSERT [Statuses] OFF;

GO

CREATE INDEX [IX_Carts_ProductID] ON [Carts] ([ProductID]);

GO

ALTER TABLE [Carts] ADD CONSTRAINT [FK_Carts_Products_ProductID] FOREIGN KEY ([ProductID]) REFERENCES [Products] ([Id]) ON DELETE CASCADE;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200412154012_rahaf', N'2.1.14-servicing-32113');

GO

UPDATE [AspNetRoles] SET [ConcurrencyStamp] = N'352a29e2-02de-4f13-ace5-b5223f354778'
WHERE [Id] = 1;
SELECT @@ROWCOUNT;


GO

UPDATE [AspNetRoles] SET [ConcurrencyStamp] = N'89e6762d-9e61-459b-9a19-9d3b2ea78b83'
WHERE [Id] = 2;
SELECT @@ROWCOUNT;


GO

UPDATE [AspNetRoles] SET [ConcurrencyStamp] = N'fc2eeb66-c33b-4d07-81cf-7d72b847c1e1'
WHERE [Id] = 3;
SELECT @@ROWCOUNT;


GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200412154722_aa', N'2.1.14-servicing-32113');

GO


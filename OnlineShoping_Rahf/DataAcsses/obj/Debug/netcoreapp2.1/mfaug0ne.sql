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


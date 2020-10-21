
GO
SET IDENTITY_INSERT [dbo].[Action] ON 

GO
INSERT [dbo].[Action] ([Id], [Name], [DisplayName]) VALUES (1, N'Index', N'Listar')
GO
INSERT [dbo].[Action] ([Id], [Name], [DisplayName]) VALUES (2, N'Create', N'Crear')
GO
INSERT [dbo].[Action] ([Id], [Name], [DisplayName]) VALUES (3, N'Edit', N'Editar')
GO
INSERT [dbo].[Action] ([Id], [Name], [DisplayName]) VALUES (4, N'Delete', N'Eliminar')
GO
INSERT [dbo].[Action] ([Id], [Name], [DisplayName]) VALUES (5, N'ChangePassword', N'Cambiar contraseña')
GO
SET IDENTITY_INSERT [dbo].[Action] OFF
GO
SET IDENTITY_INSERT [dbo].[Controller] ON 

GO
INSERT [dbo].[Controller] ([Id], [Name], [DisplayName]) VALUES (1, N'Home', N'Inicio')
GO
INSERT [dbo].[Controller] ([Id], [Name], [DisplayName]) VALUES (2, N'Role', N'Rol')
GO
INSERT [dbo].[Controller] ([Id], [Name], [DisplayName]) VALUES (3, N'RolePermission', N'Permiso')
GO
INSERT [dbo].[Controller] ([Id], [Name], [DisplayName]) VALUES (4, N'User', N'Usuario')
GO
SET IDENTITY_INSERT [dbo].[Controller] OFF
GO
SET IDENTITY_INSERT [dbo].[Permission] ON 

GO
INSERT [dbo].[Permission] ([Id], [ActionId], [ControllerId]) VALUES (1, 1, 1)
GO
INSERT [dbo].[Permission] ([Id], [ActionId], [ControllerId]) VALUES (2, 1, 2)
GO
INSERT [dbo].[Permission] ([Id], [ActionId], [ControllerId]) VALUES (3, 2, 2)
GO
INSERT [dbo].[Permission] ([Id], [ActionId], [ControllerId]) VALUES (4, 3, 2)
GO
INSERT [dbo].[Permission] ([Id], [ActionId], [ControllerId]) VALUES (5, 4, 2)
GO
INSERT [dbo].[Permission] ([Id], [ActionId], [ControllerId]) VALUES (6, 3, 3)
GO
INSERT [dbo].[Permission] ([Id], [ActionId], [ControllerId]) VALUES (7, 1, 4)
GO
INSERT [dbo].[Permission] ([Id], [ActionId], [ControllerId]) VALUES (8, 2, 4)
GO
INSERT [dbo].[Permission] ([Id], [ActionId], [ControllerId]) VALUES (9, 3, 4)
GO
INSERT [dbo].[Permission] ([Id], [ActionId], [ControllerId]) VALUES (10, 4, 4)
GO
INSERT [dbo].[Permission] ([Id], [ActionId], [ControllerId]) VALUES (11, 5, 4)
GO
SET IDENTITY_INSERT [dbo].[Permission] OFF
GO
SET IDENTITY_INSERT [dbo].[Role] ON 

GO
INSERT [dbo].[Role] ([Id], [Name], [IsActive]) VALUES (1, N'Administrador', 1)
GO
SET IDENTITY_INSERT [dbo].[Role] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

GO
INSERT [dbo].[User] ([Id], [UserName], [Password], [IsLocked], [IsActive]) VALUES (1, N'Kdos', N'v+csuOuXQl0vee2HeXvhRg==', 0, 1)
GO
SET IDENTITY_INSERT [dbo].[User] OFF
GO
SET IDENTITY_INSERT [dbo].[UserRole] ON 

GO
INSERT [dbo].[UserRole] ([Id], [UserId], [RoleId], [IsActive]) VALUES (1, 1, 1, 1)
GO
SET IDENTITY_INSERT [dbo].[UserRole] OFF
GO
SET IDENTITY_INSERT [dbo].[RolePermission] ON 

GO
INSERT [dbo].[RolePermission] ([Id], [PermissionId], [RoleId], [IsActive]) VALUES (1, 1, 1, 1)
GO
INSERT [dbo].[RolePermission] ([Id], [PermissionId], [RoleId], [IsActive]) VALUES (2, 2, 1, 1)
GO
INSERT [dbo].[RolePermission] ([Id], [PermissionId], [RoleId], [IsActive]) VALUES (3, 3, 1, 1)
GO
INSERT [dbo].[RolePermission] ([Id], [PermissionId], [RoleId], [IsActive]) VALUES (4, 4, 1, 1)
GO
INSERT [dbo].[RolePermission] ([Id], [PermissionId], [RoleId], [IsActive]) VALUES (5, 5, 1, 1)
GO
INSERT [dbo].[RolePermission] ([Id], [PermissionId], [RoleId], [IsActive]) VALUES (6, 6, 1, 1)
GO
INSERT [dbo].[RolePermission] ([Id], [PermissionId], [RoleId], [IsActive]) VALUES (7, 7, 1, 1)
GO
INSERT [dbo].[RolePermission] ([Id], [PermissionId], [RoleId], [IsActive]) VALUES (8, 8, 1, 1)
GO
INSERT [dbo].[RolePermission] ([Id], [PermissionId], [RoleId], [IsActive]) VALUES (9, 9, 1, 1)
GO
INSERT [dbo].[RolePermission] ([Id], [PermissionId], [RoleId], [IsActive]) VALUES (10, 10, 1, 1)
GO
INSERT [dbo].[RolePermission] ([Id], [PermissionId], [RoleId], [IsActive]) VALUES (11, 11, 1, 1)
GO
SET IDENTITY_INSERT [dbo].[RolePermission] OFF
GO
SET IDENTITY_INSERT [dbo].[Menu] ON 

GO
INSERT [dbo].[Menu] ([Id], [Name], [Order], [ParentMenuId], [PermissionId], [Icon]) VALUES (1, N'Seguridad', 99, NULL, NULL, N'fa fa-lock')
GO
INSERT [dbo].[Menu] ([Id], [Name], [Order], [ParentMenuId], [PermissionId], [Icon]) VALUES (2, N'Usuarios', 1, 1, 7, NULL)
GO
INSERT [dbo].[Menu] ([Id], [Name], [Order], [ParentMenuId], [PermissionId], [Icon]) VALUES (3, N'Roles', 2, 1, 2, NULL)
GO
SET IDENTITY_INSERT [dbo].[Menu] OFF
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191213202626_Initial', N'2.2.6-servicing-10079')
GO

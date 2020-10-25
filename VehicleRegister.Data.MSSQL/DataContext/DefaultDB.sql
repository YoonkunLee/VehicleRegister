INSERT INTO dbo.Manufacturers(Id, Name) VALUES(NEWID(), 'Mazda');
INSERT INTO dbo.Manufacturers(Id, Name) VALUES(NEWID(), 'Mercedes');
INSERT INTO dbo.Manufacturers(Id, Name) VALUES(NEWID(), 'Honda');
INSERT INTO dbo.Manufacturers(Id, Name) VALUES(NEWID(), 'Ferrari');
INSERT INTO dbo.Manufacturers(Id, Name) VALUES(NEWID(), 'Toyota');

INSERT INTO dbo.Categories(Id, Name, StartRange, FinishRange, IconPath) VALUES(NEWID(), 'Light', '0', '500', 'Light.jpg');
INSERT INTO dbo.Categories(Id, Name, StartRange, FinishRange, IconPath) VALUES(NEWID(), 'Medium', '500', '2500', 'Medium.jpg');
INSERT INTO dbo.Categories(Id, Name, StartRange, FinishRange, IconPath) VALUES(NEWID(), 'Heavy', '2500', NULL, 'Heavy.jpg');

INSERT INTO dbo.RegisteredVehicles(Id, OwnerName, Manufacturer, Year, Weight, Category, IconPath) VALUES(NEWID(), 'Test1', 'Honda', '2010', '300', 'Light', 'Light.jpg');
INSERT INTO dbo.RegisteredVehicles(Id, OwnerName, Manufacturer, Year, Weight, Category, IconPath) VALUES(NEWID(), 'Test2', 'Mazda', '2015', '1000', 'Medium', 'Medium.jpg');
INSERT INTO dbo.RegisteredVehicles(Id, OwnerName, Manufacturer, Year, Weight, Category, IconPath) VALUES(NEWID(), 'Test3', 'Ferrari', '2020', '3000', 'Heavy', 'Heavy.jpg');

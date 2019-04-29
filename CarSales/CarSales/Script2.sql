
--CREATE TABLE CarSaler([Id] INT IDENTITY(1,1) PRIMARY KEY, Carmaker NVARCHAR(100), CarModel NVARCHAR(100), SalePriceInDollar int, SaleDate DATETIME );

--INSERT INTO CarSaler(Carmaker,CarModel, SalePriceInDollar,SaleDate) VALUES('Maker A','A Model', 100000, '20190318 10:34:09 AM');
--INSERT INTO CarSaler(Carmaker,CarModel, SalePriceInDollar,SaleDate) VALUES('Maker B','B Model', 200000, '20190318 10:34:09 AM');
--INSERT INTO CarSaler(Carmaker,CarModel, SalePriceInDollar,SaleDate) VALUES('Maker C','C Model', 700000, '20190318 10:34:09 AM');
--INSERT INTO CarSaler(Carmaker,CarModel, SalePriceInDollar,SaleDate) VALUES('Maker D','C Model', 500000, '20190118 10:34:09 AM');

--SELECT Carmaker, CarModel, COUNT(*) AS TotalSalePrice
--FROM CarSales 
--WHERE SaleDate >= DATEADD(SaleDate,-30, getdate()) 
--GROUP BY Carmaker, CarModel


--SELECT Carmaker, CarModel, SUM(SalePriceInDollar) AS TotalSalePrice FROM CarSaler
--WHERE SaleDate >= DATEADD(DAY,-30, getdate()) 
--GROUP BY Carmaker, CarModel;


--CREATE TABLE CarModel(CarModelId INT  PRIMARY KEY,Carmaker NVARCHAR(100),CarModel NVARCHAR(100))
--CREATE TABLE CarSale(SaleDate DATETIME, CarModelId INT, SalePrice INT)

--INSERT INTO CarModel(CarModelId, Carmaker, CarModel) 
--VALUES(1, 'Maker A', 'A Model');

--INSERT INTO CarModel(CarModelId, Carmaker, CarModel) 
--VALUES(2, 'Maker B', 'B Model');

--INSERT INTO CarModel(CarModelId, Carmaker, CarModel) 
--VALUES(3, 'Maker C', 'B Model');

--INSERT INTO CarSale(SaleDate, CarModelId, SalePrice) 
--VALUES('20190218 10:34:09 AM', 2, 600000);

--INSERT INTO CarSale(SaleDate, CarModelId, SalePrice) 
--VALUES('20190318 10:34:09 AM', 2, 800000);

--INSERT INTO CarSale(SaleDate, CarModelId, SalePrice) 
--VALUES('20190118 10:34:09 AM', 3, 500000);

--SELECT * FROM 
--FULL JOIN  CarModel
--ON CarSale.CarModelId=CarModel.CarModelId

SELECT Carmaker, COUNT(*) AS SalesCount 
FROM CarModel INNER JOIN CarSale 
ON CarModel.CarModelId=CarSale.CarModelId

GROUP BY Carmaker



--DELETE C1 
--FROM CarSaler C1, CarSaler C2
--WHERE C1.Carmaker = C2.Carmaker 

--SELECT * FROM CarSaler
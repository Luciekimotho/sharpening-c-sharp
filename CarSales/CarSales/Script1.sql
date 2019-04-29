
CREATE TABLE CarSales(CarMaker text PRIMARY KEY, CarModel text, SalePriceInDollar int, SaleDate date );

INSERT INTO CarSales VALUES('Maker A','A Model', 100000, '2019-03-20');
INSERT INTO CarSales VALUES('Maker B','B Model', 200000, '2019-03-20');
INSERT INTO CarSales VALUES('Maker C','C Model', 100000, '2019-03-20');
INSERT INTO CarSales VALUES('Maker D','C Model', 100000, '2019-03-20');


SELECT Carmaker, CarModel, COUNT(*) AS TotalSalePrice
FROM CarSales 
WHERE SaleDate >= DATEADD(SaleDate,-30, getdate()) 
GROUP BY Carmaker, CarModel

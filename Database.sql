CREATE DATABASE IF NOT EXISTS minipreco;

USE minipreco;

CREATE TABLE IF NOT EXISTS Clients (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(255) NOT NULL,
    Type VARCHAR(50),
    Email VARCHAR(255),
    PhoneNumber VARCHAR(20),
    Address VARCHAR(255),
    RegistrationDate DATETIME,
    State VARCHAR(50)
);

CREATE TABLE IF NOT EXISTS Sales (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    OrderNumber INT NOT NULL,
    OrderDate DATETIME,
    DispatchDate DATETIME,
    DeliveryDate DATETIME,
    ClientId INT,
    TotalAmount DECIMAL(10, 2),
    FOREIGN KEY (ClientId) REFERENCES Clients(Id)
);

CREATE TABLE IF NOT EXISTS SaleItems (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    SaleId INT,
    ProductName VARCHAR(255) NOT NULL,
    Quantity INT,
    UnitPrice DECIMAL(10, 2),
    TotalPrice DECIMAL(10, 2),
    FOREIGN KEY (SaleId) REFERENCES Sales(Id)
);

CREATE TABLE IF NOT EXISTS Suppliers (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(255) NOT NULL,
    ContactEmail VARCHAR(255),
    PhoneNumber VARCHAR(20),
    Address VARCHAR(255),
    RegistrationDate DATETIME
);

CREATE TABLE IF NOT EXISTS Products (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(255) NOT NULL,
    SupplierId INT,
    QuantityInStock INT,
    UnitPrice DECIMAL(10, 2),
    StartDate DATETIME,
    EndDate DATETIME,
    FOREIGN KEY (SupplierId) REFERENCES Suppliers(Id)
);

drop database if exists minipreco;

create database minipreco;

use minipreco;

create table clients
(
    Id               int auto_increment
        primary key,
    Name             varchar(255) not null,
    Type             varchar(50)  null,
    Email            varchar(255) null,
    PhoneNumber      varchar(20)  null,
    Address          varchar(255) null,
    RegistrationDate datetime     null,
    State            varchar(50)  null,
    NIF              int          null
);

create table sales
(
    Id           int auto_increment
        primary key,
    OrderNumber  int            not null,
    OrderDate    datetime       null,
    DispatchDate datetime       null,
    DeliveryDate datetime       null,
    ClientId     int            null,
    TotalAmount  decimal(10, 2) null,
    constraint sales_ibfk_1
        foreign key (ClientId) references clients (Id)
);

create table saleitems
(
    Id          int auto_increment
        primary key,
    SaleId      int            null,
    ProductName varchar(255)   not null,
    Quantity    int            null,
    UnitPrice   decimal(10, 2) null,
    TotalPrice  decimal(10, 2) null,
    constraint saleitems_ibfk_1
        foreign key (SaleId) references sales (Id)
);

create index SaleId
    on saleitems (SaleId);

create index ClientId
    on sales (ClientId);

create table suppliers
(
    Id               int auto_increment
        primary key,
    Name             varchar(255) not null,
    ContactEmail     varchar(255) null,
    PhoneNumber      varchar(20)  null,
    Address          varchar(255) null,
    RegistrationDate datetime     null
);

create table products
(
    Id              int auto_increment
        primary key,
    Name            varchar(255)   not null,
    SupplierId      int            null,
    QuantityInStock int            null,
    UnitPrice       decimal(10, 2) null,
    StartDate       datetime       null,
    EndDate         datetime       null,
    constraint products_ibfk_1
        foreign key (SupplierId) references suppliers (Id)
);

create index SupplierId
    on products (SupplierId);



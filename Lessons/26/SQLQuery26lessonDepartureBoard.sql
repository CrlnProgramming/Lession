 --AirportInfo
 CREATE TABLE [DepartureBoard]
 (
 FlightNumber int,
 City nvarchar(10) NOT NULL,
 CountryDeparture nvarchar(2) NOT NULL,
 CountreArrival nvarchar(2) NOT NULL,
 DateDeparture date NOT NULL,
 DateArrival date NOT NULL,
 DateFlight datetime NOT NULL,
 NameAirlines nvarchar(15) NOT NULL,
 ModelPlane nvarchar (50) NOT NULL
 )
 INSERT INTO DepartureBoard(FlightNumber,City,CountryDeparture,CountreArrival,DateDeparture,DateArrival,DateFlight,
 NameAirlines,ModelPlane) 
 VALUES (21144,'Moscow','RU','GE','2019-06-25 04:25:00','2019-06-26 07:30:32','03:05:32','S-7','Boing-431'),
        (22834,'Paris','FR','US','2019-06-26 22:55:20','2019-06-27 00:30:32','22:25:12','Hanza','Airbus-231V')

Select * From DepartureBoard;

DROP TABLE DepartureBoard;
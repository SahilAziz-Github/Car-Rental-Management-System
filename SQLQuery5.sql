SELECT B.BookingID, B.DateTimen, C.Model, C.Brand, C.Rent
FROM Booking B, CarInformation C
WHERE B.CarID = C.C_Id
AND B.BookingID = 1022
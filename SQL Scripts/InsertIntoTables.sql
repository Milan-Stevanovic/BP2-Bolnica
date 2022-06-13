INSERT INTO Bolnica VALUES ('Bolnica Novi Sad');
INSERT INTO Bolnica VALUES ('Bolnica Beograd');
INSERT INTO Bolnica VALUES ('Bolnica Nis');

INSERT INTO Zaposleni VALUES (1111111111111, 'Marko', 'Markovic', 120000, 'ZdravstveniRadnik', 1);
INSERT INTO Zaposleni VALUES (2222222222222, 'Milos', 'Milosevic', 80000, 'Obezbedjenje', 1);
INSERT INTO Zaposleni VALUES (3333333333333, 'Jovana', 'Jovanovic', 50000, 'Spremacica', 1);
INSERT INTO Zaposleni VALUES (4444444444444, 'Steva', 'Stevanovic', 150000, 'ZdravstveniRadnik', 1);
INSERT INTO Zaposleni VALUES (5555555555555, 'Petar', 'Petrovic', 135000, 'ZdravstveniRadnik', 1);
INSERT INTO Zaposleni VALUES (6666666666666, 'Nikola', 'Nikolic', 115000, 'ZdravstveniRadnik', 1);
INSERT INTO Zaposleni VALUES (7777777777777, 'Mihajlo', 'Mihajlovic', 90000, 'Obezbedjenje', 1);
INSERT INTO Zaposleni VALUES (8888888888888, 'Marija', 'Marijanovic', 55000, 'Spremacica', 1);
INSERT INTO Zaposleni VALUES (9999999999999, 'Ivana', 'Ivanovic', 110000, 'ZdravstveniRadnik', 1);

INSERT INTO ZdravstveniRadnik VALUES (1, 111, 'Doktor');
INSERT INTO ZdravstveniRadnik VALUES (4, 444, 'Doktor');
INSERT INTO ZdravstveniRadnik VALUES (5, 555, 'Doktor');
INSERT INTO ZdravstveniRadnik VALUES (6, 666, 'MedicinskiTehnicar');
INSERT INTO ZdravstveniRadnik VALUES (9, 999, 'MedicinskiTehnicar');

INSERT INTO Obezbedjenje VALUES (2, 0);
INSERT INTO Obezbedjenje VALUES (7, 1);

INSERT INTO Odeljenje VALUES ('Opste', 1);
INSERT INTO Odeljenje VALUES ('Pulmologija', 2);
INSERT INTO Odeljenje VALUES ('Hirurgija', 3);
INSERT INTO Odeljenje VALUES ('Karidilogija', 4);
INSERT INTO Odeljenje VALUES ('Psihijatrija', 5);
INSERT INTO Odeljenje VALUES ('Urologija', 6);
INSERT INTO Odeljenje VALUES ('Oftalmologija', 7);

INSERT INTO Spremacica VALUES (3, 1);
INSERT INTO Spremacica VALUES (8, 3);

INSERT INTO Doktor VALUES (1, 'Kardiologija');
INSERT INTO Doktor VALUES (4, 'Urologija');
INSERT INTO Doktor VALUES (5, 'Psihijatrija');

INSERT INTO MedicinskiTehnicar VALUES (6);
INSERT INTO MedicinskiTehnicar VALUES (9);

INSERT INTO Pacijent VALUES (1111, 2112211221121, 'Milan', 'Stevanovic');
INSERT INTO Pacijent VALUES (2222, 1231231231231, 'Era', 'Ojdanic');
INSERT INTO Pacijent VALUES (3333, 2473650210000, 'Bora', 'Drljaca');
INSERT INTO Pacijent VALUES (4444, 4444333322221, 'Aca', 'Lukas');
INSERT INTO Pacijent VALUES (5555, 5555555566666, 'Baja Mali', 'Knindza');
INSERT INTO Pacijent VALUES (6666, 7687687867687, 'Nikola', 'Rokvic');

INSERT INTO Pregled VALUES ('2022-06-15', '15:00:00', 1111, 6);
INSERT INTO Pregled VALUES ('2022-06-16', '16:30:00', 2222, 6);
INSERT INTO Pregled VALUES ('2022-06-17', '12:15:00', 3333, 6);
INSERT INTO Pregled VALUES ('2022-07-02', '08:30:00', 4444, 9);
INSERT INTO Pregled VALUES ('2022-07-04', '10:45:00', 5555, 9);
INSERT INTO Pregled VALUES ('2022-07-01', '09:15:00', 6666, 9);

INSERT INTO ObavljaPregled VALUES (1, 1);
INSERT INTO ObavljaPregled VALUES (1, 2);
INSERT INTO ObavljaPregled VALUES (4, 3);
INSERT INTO ObavljaPregled VALUES (4, 4);
INSERT INTO ObavljaPregled VALUES (5, 5);
INSERT INTO ObavljaPregled VALUES (5, 6);

INSERT INTO OperacionaSala VALUES ('SalaPulmologija', 1, 2, 2);
INSERT INTO OperacionaSala VALUES ('SalaOftalmologija', 0, 7, 7);
INSERT INTO OperacionaSala VALUES ('SalaHirurgija', 1, 3, 3);
INSERT INTO OperacionaSala VALUES ('SalaKardiologija', 1, 4, 4);

INSERT INTO Intervencija VALUES ('2022-08-10', '07:30:00', 180, 4, 3, 3, 3);
INSERT INTO Intervencija VALUES ('2022-08-12', '08:00:00', 60,  1, 2, 4, 4);
INSERT INTO Intervencija VALUES ('2022-08-14', '08:15:00', 90,  5, 6, 1, 2);
INSERT INTO Intervencija VALUES ('2022-08-16', '07:45:00', 120, 4, 4, 3, 3);
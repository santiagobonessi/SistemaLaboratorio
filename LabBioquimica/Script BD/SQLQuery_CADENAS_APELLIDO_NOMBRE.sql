-- Apellido de Pacientes
SELECT apellido FROM Pacientes

SELECT 
  apellido,
  SUBSTRING(apellido,0,CHARINDEX(' ',apellido)) AS apellidoMod
FROM Pacientes

UPDATE Pacientes SET apellido = SUBSTRING(apellido,0,CHARINDEX(' ',apellido))

-- Nombre de Pacientes

SELECT nombre FROM Pacientes

SELECT nombre, SUBSTRING(nombre,CHARINDEX(' ',nombre)+1, 50) AS nombreMod FROM Pacientes

UPDATE Pacientes SET nombre = SUBSTRING(nombre,CHARINDEX(' ',nombre)+1, 50)

-- Apellido de Profesionales

SELECT apellido FROM Profesionales

SELECT 
  apellido,
  SUBSTRING(apellido,0,CHARINDEX(' ',apellido)) AS apellidoMod
FROM Profesionales

UPDATE Profesionales SET apellido = SUBSTRING(apellido,0,CHARINDEX(' ',apellido))
WHERE apellido NOT IN  ('GALETTO', 'DE LA VEGA MARCELO', 'MOISO',
'3º CUERPO DE INFANTERIA DEL EJERCITO DEL NORTE', 'LO GIUDICE ALBERTO', 'DA VALLE DANIEL', 'D´ ALOISIO HUGO',
'LA FALCE CARLOS', 'BERASATEGUI', 'LA GIUDICE ALBERTO','DI GIORGIO ROBERTO','BEDINI ROCCA MARIELA '
,'RACCA' ,'BASSALLO' ,'LA FUENTE LAURA' ,' DI GIORGI DANIEL ', 'SERRA', 'PAREDES', 'ANGELICI')

SELECT nombre FROM Profesionales

SELECT nombre, SUBSTRING(nombre,CHARINDEX(' ',nombre)+1, 50) AS nombreMod FROM Profesionales

UPDATE Profesionales SET nombre = SUBSTRING(nombre,CHARINDEX(' ',nombre)+1, 50)
WHERE apellido NOT IN  ('GALETTO', 'DE LA VEGA MARCELO', 'MOISO',
'3º CUERPO DE INFANTERIA DEL EJERCITO DEL NORTE', 'LO GIUDICE ALBERTO', 'DA VALLE DANIEL', 'D´ ALOISIO HUGO',
'LA FALCE CARLOS', 'BERASATEGUI', 'LA GIUDICE ALBERTO','DI GIORGIO ROBERTO','BEDINI ROCCA MARIELA '
,'RACCA' ,'BASSALLO' ,'LA FUENTE LAURA' ,' DI GIORGI DANIEL ', 'SERRA', 'PAREDES', 'ANGELICI')
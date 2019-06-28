SELECT * FROM [Laboratorio].[dbo].Analisis

SELECT * FROM [Prueba_Lab].[dbo].Analisis

SELECT * FROM [Prueba_Lab].[dbo].Analisis WHERE [Prueba_Lab].[dbo].Analisis.codigo IS NULL

UPDATE [Prueba_Lab].[dbo].[Analisis]
SET [Prueba_Lab].[dbo].[Analisis].codigo = (SELECT [Laboratorio].[dbo].[Analisis].codigo 
											FROM [Laboratorio].[dbo].[Analisis]
											WHERE [Laboratorio].[dbo].[Analisis].nombre LIKE '%'+[Prueba_Lab].[dbo].[Analisis].nombre + '%'),
[Prueba_Lab].[dbo].[Analisis].unidadBioquimica = (SELECT [Laboratorio].[dbo].[Analisis].unidadBioquimica 
											FROM [Laboratorio].[dbo].[Analisis]
											WHERE [Laboratorio].[dbo].[Analisis].nombre LIKE '%'+[Prueba_Lab].[dbo].[Analisis].nombre + '%');


											

USE db_zoo
GO

CREATE PROCEDURE SpeciesInfo @SpeciesName varchar(100), @SpeciesHabitat varchar(100) AS
SELECT specialist_fname, specialist_lname, specialist_contact
FROM tbl_specialist
INNER JOIN tbl_care ON tbl_specialist.specialist_id = tbl_care.care_specialist
INNER JOIN tbl_species ON tbl_care.care_id = tbl_species.species_care
WHERE species_name = @SpeciesName
AND species_habitat = @SpeciesHabitat
;
GO

EXEC SpeciesInfo @SpeciesName= 'brown bear', @SpeciesHabitat= '5007'
GO

SELECT * FROM tbl_species
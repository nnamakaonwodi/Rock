/* Code Generate 'AddGroupTypeGroupAttribute(...)' for migrations. 
This will list all of the group type attributes in order by group type and order 
Just pick the top few that you need for your migration .
*/

BEGIN

DECLARE
@crlf varchar(2) = char(13) + char(10)

DECLARE @EntityTypeId int
SET @EntityTypeId = (SELECT [Id] FROM [EntityType] WHERE [Name] = 'Rock.Model.Group')
                
-- AddGroupTypeGroupAttribute( string groupTypeGuid, string fieldTypeGuid, string name, string description, int order, string defaultValue, string guid )
SELECT 
        '            AddGroupTypeGroupAttribute("'+    
		CONVERT(nvarchar(50), GT.[Guid]) + '","' +
        CONVERT(nvarchar(50), FT.[Guid])+ '","' + 
		A.[Name] + '","' +
		A.[Description] + '",' +
		CONVERT(varchar(5), A.[Order]) + ',' +
		(CASE 
		 WHEN A.[DefaultValue] IS NULL THEN 'null' 
		 ELSE + '"' + A.[DefaultValue] + '"' 
		 END)+ ',"' +
        CONVERT(nvarchar(50), A.[Guid])+ '");' + @crlf
  FROM [Attribute] A
  INNER JOIN [GroupType] GT ON GT.[Id] = A.[EntityTypeQualifierValue]
  INNER JOIN [FieldType] FT ON FT.[Id] = A.[FieldTypeId]
  WHERE
	A.[EntityTypeQualifierColumn] = 'GroupTypeId'
	AND A.[EntityTypeId] = @EntityTypeId
ORDER BY GT.[Name], A.[Order] 


SELECT 
        '            DeleteAttribute("' +    
        CONVERT(nvarchar(50), A.[Guid])+ '");    // GroupType - ' + 
		GT.[Name] + ': ' +
		A.[Name] + @crlf
  FROM [Attribute] A
  INNER JOIN [GroupType] GT ON GT.Id = A.[EntityTypeQualifierValue]
  INNER JOIN [FieldType] FT ON FT.Id = A.[FieldTypeId]
  WHERE A.[EntityTypeQualifierColumn] = 'GroupTypeId' AND A.[EntityTypeId] = @EntityTypeId
ORDER BY GT.[Name], A.[Order] 

END

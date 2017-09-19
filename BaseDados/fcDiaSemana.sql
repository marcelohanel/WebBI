USE [KPI]
GO

/****** Object:  UserDefinedFunction [dbo].[getDiaSemana]    Script Date: 03/10/2012 08:07:06 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[fcDiaSemana] (@Data DATETIME) RETURNS VARCHAR (20)  AS
BEGIN
  DECLARE @DIA INT,
   @DIA_EXT VARCHAR(20)
  
  SELECT @DIA = (DATEPART(DW,@DATA ))
 
  IF @DIA=1 
     SET @DIA_EXT = 'Domingo'
  IF @DIA=2  
     SET @DIA_EXT = 'Segunda-Feira'
  IF @DIA=3  
     SET @DIA_EXT = 'Terça-Feira'
  IF @DIA=4  
     SET @DIA_EXT = 'Quarta-Feira'
  IF @DIA=5  
     SET @DIA_EXT = 'Quinta-Feira'
  IF @DIA=6  
     SET @DIA_EXT = 'Sexta-Feira'
  IF @DIA=7  
     SET @DIA_EXT = 'Sábado';
 
  RETURN @DIA_EXT
END

GO



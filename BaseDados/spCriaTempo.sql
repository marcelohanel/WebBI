USE [KPI]
GO

/****** Object:  StoredProcedure [dbo].[spCriaTempo]    Script Date: 03/10/2012 08:06:32 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spCriaTempo] 
@DtInicio as datetime,
@DtFim    as datetime
AS
BEGIN
	SET NOCOUNT ON;

    delete from tempo
    where data >= cast(@DtInicio as date)
      and data <= cast(@DtFim as date)
      
	declare @data      as date
	declare @trimestre as int
	declare @semestre  as int
	declare @seculo    as int
	declare @decada    as int
	declare @ano       as int
	declare @dia       as int
	declare @mes       as int
	declare @ano_lit   as int

	select @data = @DtInicio
	
	while @data <= @DtFim
	begin
		select @ano     = cast(datepart(yy,@data) as int)
		select @mes     = cast(datepart(mm,@data) as int)
		select @dia     = cast(datepart(dd,@data) as int)
		select @seculo  = cast(@ano / 100 as int) + 1
		select @ano_lit = cast(@ano - ((@seculo - 1) * 100) as int)

		if @ano_lit < 10  begin select @decada = 1  end else
		if @ano_lit < 20  begin select @decada = 2  end else
		if @ano_lit < 30  begin select @decada = 3  end else
		if @ano_lit < 40  begin select @decada = 4  end else
		if @ano_lit < 50  begin select @decada = 5  end else
		if @ano_lit < 60  begin select @decada = 6  end else
		if @ano_lit < 70  begin select @decada = 7  end else
		if @ano_lit < 80  begin select @decada = 8  end else
		if @ano_lit < 90  begin select @decada = 9  end else
		if @ano_lit < 100 begin select @decada = 10 end

		select @trimestre = case datepart(mm,@data) 
							when 1 then 1 
							when 2 then 1 
							when 3 then 1 
							when 4 then 2 
							when 5 then 2
							when 6 then 2 
							when 7 then 3 
							when 8 then 3
							when 9 then 3 
							when 10 then 4 
							when 11 then 4 
							when 12 then 4 
							end

		select @semestre = case datepart(mm,@data) 
							when 1 then 1 
							when 2 then 1 
							when 3 then 1 
							when 4 then 1 
							when 5 then 1
							when 6 then 1 
							when 7 then 2 
							when 8 then 2
							when 9 then 2 
							when 10 then 2 
							when 11 then 2 
							when 12 then 2 
							end

		insert into tempo (data, mes, dia, ano, trimestre, semestre, mes_ano, dia_semana, num_dia_semana, num_dia_ano, num_semana, seculo, decada, decada_seculo)
		values 
		(
		   @data,
		   @mes,
		   @dia,
		   @ano,
		   @trimestre,
		   @semestre,
		   replace(str(@mes,2,0),' ','0') + '/' + replace(str(@ano,4,0),' ','0'),
		   dbo.getDiaSemana(@data),
		   datepart(dw,@data),
		   datepart(dy,@data),
		   datepart(wk,@data),
		   @seculo,
		   @decada,
		   replace(str(@decada,2,0),' ','0') + '/' + replace(str(@seculo,2,0),' ','0')
		)
		
		select @data = dateadd(day, 1, @data)
	end

END

GO



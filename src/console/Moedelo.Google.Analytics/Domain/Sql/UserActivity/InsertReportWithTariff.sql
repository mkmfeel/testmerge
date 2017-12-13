insert into moedelo_tariff_id
		(dimension2,
			dimension8,
			[sessions],
			create_date)
	values
		(@SessionId,
			@TariffId,
			@Sessions,
			getdate());
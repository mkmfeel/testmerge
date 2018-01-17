insert into _company_id
		(dimension2,
			dimension4,
			[sessions],
			create_date)
	values
		(@SessionId,
			@CompanyId,
			@Sessions,
			getdate());
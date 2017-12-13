insert into moedelo_employees
		(dimension2,
			dimension9,
			[sessions],
			create_date)
	values
		(@SessionId,
			@Employyes,
			@Sessions,
			getdate());
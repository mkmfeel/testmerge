insert into moedelo_account_reg_date
		(dimension2,
			dimension5,
			[sessions],
			create_date)
	values
		(@SessionId,
			@AccountRegDate,
			@Sessions,
			getdate());
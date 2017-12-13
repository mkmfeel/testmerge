insert into moedelo_session_type
		(dimension2,
			dimension6,
			[sessions],
			create_date)
	values
		(@SessionId,
			@SessionType,
			@Sessions,
			getdate());
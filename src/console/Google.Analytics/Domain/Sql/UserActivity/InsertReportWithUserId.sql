insert into _user_id
		(dimension2,
			dimension3,
			[sessions],
			create_date)
	values
		(@SessionId,
			@UserId,
			@Sessions,
			getdate());
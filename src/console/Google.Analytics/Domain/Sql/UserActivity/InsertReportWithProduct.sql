insert into _product
		(dimension2,
			dimension7,
			[sessions],
			create_date)
	values
		(@SessionId,
			@Product,
			@Sessions,
			getdate());
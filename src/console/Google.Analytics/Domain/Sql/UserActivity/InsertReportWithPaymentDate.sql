insert into _payment_date
		(dimension2,
			dimension10,
			[sessions],
			create_date)
	values
		(@SessionId,
			@PaymentDate,
			@Sessions,
			getdate());
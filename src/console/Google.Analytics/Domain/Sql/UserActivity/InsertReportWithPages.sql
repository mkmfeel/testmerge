insert into _page
		(dimension2,
			dimension11,
			dimension12,
			[date],
			[sessions],
			hits,
			sessionDuration,
			create_date)
	values
		(@SessionId,
			@NumberViewPage,
			@PageUrl,
			@Date,
			@Sessions,
			@Hits,
			@SessionDuration,		
			getdate());
insert into _conversions
		(dimension2,
			[sessions],
			sessionDuration,
			goal1Completions,
			goal2Completions,
			goal3Completions,
			pageviewsPerSession,
			create_date)
	values
		(@SessionId,
			@Sessions,
			@SessionDuration,
			@Goal1Completions,
			@Goal2Completions,
			@Goal3Completions,
			@PageviewsPerSession,
			getdate());
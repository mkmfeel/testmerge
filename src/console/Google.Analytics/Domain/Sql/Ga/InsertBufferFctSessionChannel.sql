insert into BUFFER_FCT_SESSION_CHANNEL (
	session_id,
	utm_source,
	utm_medium,
	utm_campaign,
	utm_term,
	utm_placement,
	create_date)
	values (
	@session_id,
	@utm_source,
	@utm_medium,
	@utm_campaign,
	@utm_term,
	null,
	getdate())
insert into BUFFER_FCT_SESSION (
	session_id,
	client_id,
	session_time,
	create_date,
	is_reg)
	values (
	@session_id,
	@client_id,
	@session_time,
	getdate(),
	@is_reg)
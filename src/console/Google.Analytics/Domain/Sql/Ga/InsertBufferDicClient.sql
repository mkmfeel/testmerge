insert into BUFFER_DIC_CLIENT (
	client_id,
	regions,
	browser,
	create_date)
	values (
	@client_id,
	@regions,
	@browser,
	getdate())
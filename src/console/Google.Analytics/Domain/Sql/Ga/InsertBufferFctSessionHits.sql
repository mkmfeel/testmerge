insert into BUFFER_FCT_SESSION_HITS (
	session_id,
	page_in_url,
	page_out_url,
	hit_id,
	create_date)
	values(
	@session_id,
	@page_in_url,
	@page_out_url,
	@hit_id,
	getdate())
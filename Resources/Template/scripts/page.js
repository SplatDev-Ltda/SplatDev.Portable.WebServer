$(function(){
	console.log('page functions');
	$("#btnsearch").click(function(){
		$("body").removeHighlight();
		$("body").highlight($("#txtsearch").val());
	});
	$("#txtsearch").focus(function(){
		if($(this).val()!="") $(this).val("");
	});
});



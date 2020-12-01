
intertime = 500;

function gettimeout(itime){
	return itime - (+Date.now()%itime);
}

function getsvg(url){
	xmlhttp = new XMLHttpRequest();
	xmlhttp.open("GET",url,false);
	xmlhttp.send();
	return xmlhttp.responseText;
}

function draw(url){
	var curTime = new Date();
	//console.log(Date.now());
	document.getElementById('figure').innerHTML = "<b>" + curTime.toLocaleString() + "</b>" + "<br/><br/>" + getsvg(url);
	window.setTimeout(function(){draw(url)}, gettimeout(intertime));
}

function showtime(){
	var curTime = new Date();
	document.getElementById('figure').innerHTML = curTime.toLocaleString();
	window.setTimeout(showtime, gettimeout(intertime));
}

var svgurl = "/pygal/"+"current:price";
draw(svgurl);


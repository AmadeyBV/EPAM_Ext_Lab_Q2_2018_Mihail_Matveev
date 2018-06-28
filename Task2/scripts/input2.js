window.onload = function() {
	modal = document.getElementById("modal");
	background = document.getElementById("background");
	Hide();
} 

function Show() {
	background.style.filter = "alpha(opacity=80)";
	background.style.opacity = 0.8;
	background.style.display = "block";
	modal.style.display = "block";
	modal.style.top = "200px";
}

function Hide() {
	background.style.display = "none";
	modal.style.display = "none";
}   
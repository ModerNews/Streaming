function updateUser() {
    var configs = JSON.parse(data);
    document.getElementById('txt').innerHTML = configs[0].name;
    var t = setTimeout(startTime, 500);
}
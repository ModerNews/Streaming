function updateUser() {
    var configs = JSON.parse(data);
    document.getElementById('name').innerHTML = configs[0].name;
    document.getElementById('title').innerHTML = configs[0].title + " - " + configs[0].author;
    var t = setTimeout(updateUser, 500);
}
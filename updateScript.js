function updateUser() {
    var configs = JSON.parse(data);
    if (configs[0].visibility == "true"){
        document.getElementById('name').innerHTML = configs[0].name;
        document.getElementById('title').innerHTML = configs[0].title + " - " + configs[0].author;
    }else{
        document.getElementById('name').innerHTML = " ";
        document.getElementById('title').innerHTML = " ";
    }
    
    var t = setTimeout(updateUser, 500);
}
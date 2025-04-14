"use strict";

let userHubConn = new signalR.HubConnectionBuilder()
    .withUrl("/hubs/userhub")
    .build();

let respTag = document.getElementById("sngr-msg");

userHubConn.on("ReceiveMessage", (message) => {
    var txt = document.createTextNode(message);
    var div = document.createElement("div").appendChild(txt);
    respTag.appendChild(div);
    //userHubConn.invoke("SendMessage", `${Math.random() * 100}`).catch(err => console.error(err.toString()));
});

userHubConn.start()
    .then(() => {
        userHubConn.invoke("SendMessage", "Hello from userhub.js").catch(err => console.error(err.toString()));
     })


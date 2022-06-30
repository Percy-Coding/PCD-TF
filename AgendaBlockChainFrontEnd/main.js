let Connect = () => {
    const ws = new WebSocket("ws://localhost:8030");
    ws.addEventListener("open", ()=>{
        ws.send("HOLA JOVEN");
    })
}

let Agregar = () =>{
    const ws = new WebSocket("ws://localhost:8030");
    const name = document.getElementsById("name").value;
    const number = document.getElementsById("number").value;

    ws.addEventListener("open", ()=>{
        let data = {
            Name: name,
            Number: number
        }
        ws.send(JSON.stringify(data));
    })
}
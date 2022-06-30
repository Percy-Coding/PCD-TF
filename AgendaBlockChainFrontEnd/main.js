let Connect = () => {
    const ws = new WebSocket("ws://localhost:8030");
    ws.addEventListener("open", ()=>{
        ws.send("HOLA JOVEN");
    })
}

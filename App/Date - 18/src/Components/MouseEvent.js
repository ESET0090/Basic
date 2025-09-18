
function MouseEvent(){

    return(
    <>
    <div style = {{
        background:"black",
        color : "Red",
        padding:"50px",
        border:"2px solid red"
    }}
    
    onMouseEnter = {() =>{console.log("mouse entered div")}}

    > welcome to mouse events </div>
    </>
    )
}

export default MouseEvent;

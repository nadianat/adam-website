var incrementButton = document.getElementsByClassName('plus');
var decrementButton = document.getElementsByClassName('minus');
// console.log(incrementButton);
// console.log(decrementButton);

for(var i= 0; i < incrementButton.length; i++){
    
        var button = incrementButton[i];
        button.addEventListener('click', function(event){

            var buttonClicked = event.target;
            // console.log(buttonClicked);
            var input = buttonClicked.parentElement.children[1];
            // console.log(input);
            var inputValue = input.value;
            // console.log(inputValue);
            var newValue = parseInt(inputValue) + 1;
            input.value = newValue;
    })
}

for(var i= 0; i < decrementButton.length; i++){
    
        var button = decrementButton[i];
        button.addEventListener('click', function(event){

            var buttonClicked = event.target;
            // console.log(buttonClicked);
            var input = buttonClicked.parentElement.children[1];
            // console.log(input);
            var inputValue = input.value;
            // console.log(inputValue);
            var newValue = parseInt(inputValue) - 1;
            if (newValue >=0){
                input.value = newValue;
            }
            else{
                input.value= 0;
                // alert('QTY CANNOT BE LESS THAN 0')
            }
    })
}

(function ($) {
    "use strict";


    /*==================================================================
    [ Validate ]*/
    var input = $('.validate-input .input100');

    $('.validate-form').on('submit',function(){
        var check = true;

        for(var i=0; i<input.length; i++) {
            if(validate(input[i]) == false){
                showValidate(input[i]);
                check=false;
            }
        }

        return check;
    });
    var a = 2;

    $('.validate-form .input100').each(function(){
        $(this).focus(function(){
           hideValidate(this);
        });
    });

    function validate (input) {
        if ($(input).attr('type') == 'email' || $(input).attr('name') == 'email') {
            
            if($(input).val().trim().match(/^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{1,5}|[0-9]{1,3})(\]?)$/) == null) {
                return false;
                
            }
        }
        else {
            if($(input).val().trim() == ''){
                return false;
            }
        }
    }

    function showValidate(input) {
        var thisAlert = $(input).parent();

        $(thisAlert).addClass('alert-validate');
    }

    function hideValidate(input) {
        var thisAlert = $(input).parent();

        $(thisAlert).removeClass('alert-validate');
    }
    
    /*==================================================================
    [ Show pass ]*/
    var showPass = 0;
    $('.btn-show-pass').on('click', function(){
        if(showPass == 0) {
            $(this).next('input').attr('type','text');
            $(this).find('i').removeClass('fa-eye');
            $(this).find('i').addClass('fa-eye-slash');
            showPass = 1;
        }
        else {
            $(this).next('input').attr('type','password');
            $(this).find('i').removeClass('fa-eye-slash');
            $(this).find('i').addClass('fa-eye');
            showPass = 0;
        }
        
    });
})(jQuery);
    
    // Popup Al
    var modal = document.getElementById('myModal');

    // Kipi açan düğmeyi al
    var btn = document.getElementById("butonum");

    // Kipi kapatan <span> öğesini edinin
    var span = document.getElementsByClassName("close")[0];

    // Kullanıcı düğmeyi tıklattığında
    btn.onclick = function () {
        modal.style.display = "block";
    }

    // Kullanıcı <span> (x) düğmesini tıkladığında, popup
    span.onclick = function () {
        modal.style.display = "none";
    }
    //Boş yere tıklandığında pop up dan cıkılır
    window.onclick = function (event) {
        if (event.target == modal) {
            modal.style.display = "none";
        }
}


//////////////////////////
var verifyCallback = function (response) {
    alert(response);
};
var widgetId1;
var widgetId2;
var onloadCallback = function () {
    // Renders the HTML element with id 'example1' as a reCAPTCHA widget.
    // The id of the reCAPTCHA widget is assigned to 'widgetId1'.
    widgetId1 = grecaptcha.render('example1', {
        'sitekey': 'your_site_key',
        'theme': 'light'
    });
    widgetId2 = grecaptcha.render(document.getElementById('example2'), {
        'sitekey': 'your_site_key'
    });
    grecaptcha.render('example3', {
        'sitekey': 'your_site_key',
        'callback': verifyCallback,
        'theme': 'dark'
    });
};


"use strict";

var loginSigIn = $('.kt-login__signin');
var loginSigUp = $('.kt-login__signup');
function displaySignUpForm () {
    loginSigIn.css("display", "none");
    loginSigUp.css("display", "block");
    KTUtil.animateClass(login.find('.kt-login__signup')[0], 'flipInX animated');
}

function displaySignInForm () {
    loginSigUp.css("display", "none");
    loginSigIn.css("display", "block");

    KTUtil.animateClass(login.find('.kt-login__signin')[0], 'flipInX animated');
    //login.find('.kt-login__signin').animateClass('flipInX animated');
}


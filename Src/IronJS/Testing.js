﻿var y = "foo";
var z = function(foo) {
    var x = 2;
    return function() {
        return x;
    };
};
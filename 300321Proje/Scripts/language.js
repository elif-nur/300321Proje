
    var hide = document.getElementById('arabic');
    var hide1 = document.getElementById('turkish');
    hide.style.display = "none";
    hide1.style.display = "none";
    var element = document.querySelector("#english");

    var hide = document.getElementById('arabicc');
    var hide1 = document.getElementById('turkishh');
    hide.style.display = "none";
    hide1.style.display = "none";
    var element = document.querySelector("#englishh");
    

        function goster(deger) {

            if (deger === 1) {
                var hide = document.getElementById('arabic');
                var hide1 = document.getElementById('turkish');
                hide.style.display = "none";
                hide1.style.display = "none";
                var show = document.getElementById('english');
                show.style.display = "block";

                var hide = document.getElementById('arabicc');
                var hide1 = document.getElementById('turkishh');
                hide.style.display = "none";
                hide1.style.display = "none";
                var show = document.getElementById('englishh');
                show.style.display = "block";


            }
            if (deger === 2) {
                var hide = document.getElementById('english');
                var hide1 = document.getElementById('turkish');
                hide.style.display = "none";
                hide1.style.display = "none";
                var show = document.getElementById('arabic');
                show.style.display = "block";

                var hide = document.getElementById('englishh');
                var hide1 = document.getElementById('turkishh');
                hide.style.display = "none";
                hide1.style.display = "none";
                var show = document.getElementById('arabicc');
                show.style.display = "block";


            }
            if (deger === 3) {
                var hide = document.getElementById('english');
                var hide1 = document.getElementById('arabic');
                hide.style.display = "none";
                hide1.style.display = "none";
                var show = document.getElementById('turkish');
                show.style.display = "block";

                var hide = document.getElementById('englishh');
                var hide1 = document.getElementById('arabicc');
                hide.style.display = "none";
                hide1.style.display = "none";
                var show = document.getElementById('turkishh');
                show.style.display = "block";

            }
        }


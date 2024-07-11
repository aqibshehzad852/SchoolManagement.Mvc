

 // Save theme preference
 document.getElementById('toggle-theme').addEventListener('change', function () {
    localStorage.setItem('theme', this.checked ? 'dark' : 'light');
    applyTheme(); // Apply your theme styles
});

// Apply theme on page load
document.addEventListener('DOMContentLoaded', function () {
    const savedTheme = localStorage.getItem('theme');
    if (savedTheme === 'dark') {
        document.getElementById('toggle-theme').checked = true;
        applyTheme(); // Apply your theme styles
    }
});



function applyTheme() {
    const isDarkTheme = document.getElementById('toggle-theme').checked;
    
    document.body.style.backgroundColor = isDarkTheme ? '#212529' : 'white';
    
    const textColor = isDarkTheme ? 'white' : 'black';
    document.body.style.color = textColor;


}

document.getElementById("subscribeForm").addEventListener("submit", function (event) {
    event.preventDefault(); 

    var formData = new FormData(this);

    fetch(this.action, {
        method: this.method,
        body: formData
    })
        .then(response => {
            if (!response.ok) {
                throw new Error('Network response was not ok');
            }
            return response.json();
        })
        .then(data => {
            if (data.success) {
               
                Toastify({
                    text: 'Thanks for subscribing to our newsletter!',
                    duration: 3000,
                    gravity: 'top',
                    backgroundColor: '#5cb85c',
                    close: true
                }).showToast();
            } else {
                console.error('Subscription failed');
            
            }
        })
        .catch(error => {
            console.error('Error:', error);
        });
});



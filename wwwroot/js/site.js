

// Save theme preference
document.addEventListener('DOMContentLoaded', function () {
    const toggle = document.getElementById('toggle-theme');
    const savedTheme = localStorage.getItem('theme');

    // Apply saved theme
    if (savedTheme === 'dark') {
        document.body.classList.add('dark-theme');
        if (toggle) toggle.checked = true;
    } else {
        document.body.classList.remove('dark-theme');
        if (toggle) toggle.checked = false;
    }

    // Listen for changes (guard if toggle exists)
    if (toggle) {
        toggle.addEventListener('change', function () {
            const isDark = this.checked;
            localStorage.setItem('theme', isDark ? 'dark' : 'light');
            if (isDark) document.body.classList.add('dark-theme'); else document.body.classList.remove('dark-theme');
        });
    }
});

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



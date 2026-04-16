// Rating slider display
const ratingInput = document.getElementById('avgRating');
if (ratingInput) {
    ratingInput.addEventListener('input', function() {
        document.getElementById('ratingDisplay').textContent = this.value;
    });
}

// Team Builder Calculator
function calculateTeam() {
    const teamName = document.getElementById('teamName').value;
    const budget = parseInt(document.getElementById('budget').value);
    const starPlayers = parseInt(document.getElementById('starPlayers').value);
    const avgRating = parseInt(document.getElementById('avgRating').value);

    // Calculate estimated team value based on average rating and star players
    const baseValue = budget * 0.7;
    const starBonus = starPlayers * 5000000;
    const ratingBonus = (avgRating - 75) * 200000;
    const estimatedValue = baseValue + starBonus + ratingBonus;
    const remaining = budget - estimatedValue;

    // Display results
    document.getElementById('resultTeamName').textContent = teamName;
    document.getElementById('resultBudget').textContent = budget.toLocaleString();
    document.getElementById('resultValue').textContent = Math.round(estimatedValue).toLocaleString();
    document.getElementById('resultAvgRating').textContent = avgRating;
    document.getElementById('resultStars').textContent = starPlayers;
    document.getElementById('resultRemaining').textContent = Math.round(remaining).toLocaleString();

    document.getElementById('results').style.display = 'block';
}

// Contact Form Handler
function submitForm(event) {
    event.preventDefault();
    const form = document.getElementById('contactForm');
    const formMessage = document.getElementById('formMessage');
    
    const name = form.name.value;
    const email = form.email.value;
    const subject = form.subject.value;
    const message = form.message.value;

    // Simulate sending (in real app, this would go to a server)
    console.log('Form submitted:', { name, email, subject, message });

    formMessage.innerHTML = '<p style="color: #00ff00; font-weight: bold;">✓ Thank you! Your message has been sent successfully. We will get back to you soon!</p>';
    form.reset();

    // Clear message after 5 seconds
    setTimeout(() => {
        formMessage.innerHTML = '';
    }, 5000);
}

// Navigation smooth scroll
document.querySelectorAll('nav a').forEach(anchor => {
    anchor.addEventListener('click', function (e) {
        // Allow normal navigation to other pages
        // Only prevent default for same-page links
        if (this.getAttribute('href').startsWith('#')) {
            e.preventDefault();
            const target = document.querySelector(this.getAttribute('href'));
            if (target) {
                target.scrollIntoView({
                    behavior: 'smooth'
                });
            }
        }
    });
});

// Welcome message on home page
window.addEventListener('load', function() {
    const h1 = document.querySelector('h1');
    if (h1 && h1.textContent.includes('Welcome')) {
        console.log('Dream League Soccer 26 - Welcome!');
    }
});
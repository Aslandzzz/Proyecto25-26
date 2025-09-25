document.addEventListener('DOMContentLoaded', () => {
    const searchInput = document.getElementById('searchInput');
    const articles = document.querySelectorAll('.encyclopedia-entry');

    searchInput.addEventListener('keyup', (event) => {
        const query = event.target.value.toLowerCase();

        articles.forEach(article => {
            const title = article.querySelector('h2').textContent.toLowerCase();
            const content = article.textContent.toLowerCase();

            if (title.includes(query) || content.includes(query)) {
                article.style.display = 'block';
            } else {
                article.style.display = 'none';
            }
        });
    });
});

let backToTopButton = document.querySelector(".back-to-top");

window.onscroll = function() {
  if (document.body.scrollTop > 100 || document.documentElement.scrollTop > 100) {
    backToTopButton.style.display = "block";
  } else {
    backToTopButton.style.display = "none";
  }
};
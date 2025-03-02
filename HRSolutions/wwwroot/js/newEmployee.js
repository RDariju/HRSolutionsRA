
    const profileContainer = document.getElementById('profileContainer');
    const profileInput = document.getElementById('profileImageInput');

    profileContainer.addEventListener('click', () => profileInput.click());
    profileInput.addEventListener('change', (e) => previewImage(e));

    function previewImage(event) {
        const file = event.target.files[0];
    if (!file) return;

    const reader = new FileReader();
        reader.onload = () => {
            const image = document.getElementById('profileImage');
    image.src = reader.result;
    image.style.display = 'block';
    document.getElementById('uploadText').style.display = 'none';
        };
    reader.readAsDataURL(file);
    }

    document.getElementById('employeeForm').addEventListener('submit', function (e) {
        e.preventDefault();
    if (validateForm()) {
        alert('Form saved successfully!');
            // You can replace this alert with actual form submission logic (like sending to backend).
        }
    });

    function validateForm() {
        const requiredFields = document.querySelectorAll('#employeeForm input[required], #employeeForm select[required]');
    for (let field of requiredFields) {
            if (!field.value.trim()) {
        alert('Please fill out all required fields.');
    return false;
            }
        }

    const emailField = document.querySelector('input[type="email"]');
    if (emailField && !validateEmail(emailField.value)) {
        alert('Please enter a valid email address.');
    return false;
        }

    return true;
    }

    function validateEmail(email) {
        const re = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
    return re.test(String(email).toLowerCase());
    }
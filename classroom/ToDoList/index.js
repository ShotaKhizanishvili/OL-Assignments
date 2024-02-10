function addTask(){
    const container = document.getElementById('tasksContainer');
    const input = document.getElementById("input1");

    const taskTextValue = input.value.trim();

    const taskContainer = document.createElement('div');
    const taskText = document.createElement('p');
    const deleteButton = document.createElement('button');
    const markAsCompletedButton = document.createElement('button');

    taskText.textContent = taskTextValue;

    taskContainer.appendChild(taskText);
    taskContainer.appendChild(deleteButton);
    taskContainer.appendChild(markAsCompletedButton);

    container.appendChild(taskContainer);

    deleteButton.innerText = 'Delete this task';
    markAsCompletedButton.innerText = 'Mark as Completed';

    deleteButton.addEventListener('click', () => {
        taskContainer.remove();
    });

    markAsCompletedButton.addEventListener('click', () => {
        taskText.style.textDecoration = 'line-through';
    });

    input.value = '';
}
import { Component } from '@angular/core';
import { TodoListComponent } from './pages/todo-list.component';
import { RouterLink, RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-root',
  template: `
    <main class="container mx-auto">
      <div class="flex gap-4">
        <a routerLink="/" class="btn btn-primary">Home</a>
        <a routerLink="todo-list" class="btn btn-primary">See My Todo List</a>
        <a href="" class="btn btn-primary">Add an Item to My Todo List </a>
      </div>

      <router-outlet />
    </main>
  `,
  styles: [],
  imports: [RouterLink, RouterOutlet],
})
export class AppComponent {}

import { Routes } from '@angular/router';
import { BankingComponent } from './banking.component';
import { WithdrawalComponent } from './components/withdrawal.components';
import { DepositComponent } from './components/deposit.components';
export const BANKING_ROUTES: Routes = [
  {
    path: '',
    component: BankingComponent,
    children: [
      {
        path: 'withdrawal', // banking/withdrawal
        component: WithdrawalComponent,
      },
      {
        path: 'deposit',
        component: DepositComponent,
      },
    ],
  },
];

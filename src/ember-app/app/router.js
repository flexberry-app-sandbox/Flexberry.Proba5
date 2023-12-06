import EmberRouter from '@ember/routing/router';
import config from './config/environment';

const Router = EmberRouter.extend({
  location: config.locationType
});

Router.map(function () {
  this.route('i-i-s-proba-должность-l');
  this.route('i-i-s-proba-должность-e',
  { path: 'i-i-s-proba-должность-e/:id' });
  this.route('i-i-s-proba-должность-e.new',
  { path: 'i-i-s-proba-должность-e/new' });
  this.route('i-i-s-proba-сотрудник-l');
  this.route('i-i-s-proba-сотрудник-e',
  { path: 'i-i-s-proba-сотрудник-e/:id' });
  this.route('i-i-s-proba-сотрудник-e.new',
  { path: 'i-i-s-proba-сотрудник-e/new' });
});

export default Router;

import React from 'react';
import { Counter } from './Counter';
import renderer from 'react-test-renderer';


test('Component is not null', () => {
  const component = renderer.create(<Counter />);

  expect(component).not.toBe(null);
})